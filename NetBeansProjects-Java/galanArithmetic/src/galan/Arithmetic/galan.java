package galan.Arithmetic;

public class galan extends javax.swing.JFrame {

    public galan() {
        initComponents();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        num1Galan = new javax.swing.JTextField();
        submitGalan = new javax.swing.JButton();
        galanNum1 = new javax.swing.JLabel();
        num2Galan = new javax.swing.JTextField();
        galanNum2 = new javax.swing.JLabel();
        sGalan = new javax.swing.JLabel();
        lGalan1 = new javax.swing.JLabel();
        clearGalan = new javax.swing.JButton();
        dGalan = new javax.swing.JLabel();
        qGalan = new javax.swing.JLabel();
        pGalan = new javax.swing.JLabel();
        forsumGalan = new javax.swing.JTextField();
        fordiffGalan = new javax.swing.JTextField();
        forqtGalan = new javax.swing.JTextField();
        forpdGalan = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        num1Galan.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(0, 0, 0), 1, true));

        submitGalan.setBackground(new java.awt.Color(0, 153, 51));
        submitGalan.setFont(new java.awt.Font("Copperplate Gothic Light", 1, 14)); // NOI18N
        submitGalan.setForeground(new java.awt.Color(255, 255, 255));
        submitGalan.setText("SUBMIT");
        submitGalan.setBorder(new javax.swing.border.SoftBevelBorder(javax.swing.border.BevelBorder.RAISED, new java.awt.Color(204, 204, 204), new java.awt.Color(204, 204, 204), new java.awt.Color(0, 0, 0), new java.awt.Color(102, 102, 102)));
        submitGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                submitGalanActionPerformed(evt);
            }
        });

        galanNum1.setFont(new java.awt.Font("Verdana", 1, 14)); // NOI18N
        galanNum1.setText("Enter number :");

        num2Galan.setBorder(new javax.swing.border.LineBorder(new java.awt.Color(0, 0, 0), 1, true));

        galanNum2.setFont(new java.awt.Font("Verdana", 1, 14)); // NOI18N
        galanNum2.setText("Enter number :");

        sGalan.setFont(new java.awt.Font("Copperplate Gothic Light", 1, 14)); // NOI18N
        sGalan.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        sGalan.setText("Sum:");
        sGalan.setVerticalAlignment(javax.swing.SwingConstants.TOP);

        lGalan1.setFont(new java.awt.Font("Cambria Math", 0, 14)); // NOI18N
        lGalan1.setText("LET'S CALCULATE");

        clearGalan.setBackground(new java.awt.Color(255, 102, 102));
        clearGalan.setFont(new java.awt.Font("Copperplate Gothic Light", 1, 14)); // NOI18N
        clearGalan.setForeground(new java.awt.Color(255, 255, 255));
        clearGalan.setText("CLEAR");
        clearGalan.setBorder(new javax.swing.border.SoftBevelBorder(javax.swing.border.BevelBorder.RAISED, new java.awt.Color(204, 204, 204), new java.awt.Color(204, 204, 204), new java.awt.Color(0, 0, 0), new java.awt.Color(102, 102, 102)));
        clearGalan.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                clearGalanActionPerformed(evt);
            }
        });

        dGalan.setFont(new java.awt.Font("Copperplate Gothic Light", 1, 14)); // NOI18N
        dGalan.setText("Difference :");

        qGalan.setFont(new java.awt.Font("Copperplate Gothic Light", 1, 14)); // NOI18N
        qGalan.setText("Quotient :");

        pGalan.setFont(new java.awt.Font("Copperplate Gothic Light", 1, 14)); // NOI18N
        pGalan.setText("Product :");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(lGalan1, javax.swing.GroupLayout.PREFERRED_SIZE, 116, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(145, 145, 145))
            .addGroup(layout.createSequentialGroup()
                .addGap(82, 82, 82)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(2, 2, 2)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(galanNum1, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(galanNum2, javax.swing.GroupLayout.PREFERRED_SIZE, 130, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(submitGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(num1Galan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(num2Galan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE))
                                    .addComponent(clearGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(dGalan)
                                    .addComponent(qGalan))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(forqtGalan, javax.swing.GroupLayout.DEFAULT_SIZE, 80, Short.MAX_VALUE)
                                    .addComponent(fordiffGalan, javax.swing.GroupLayout.DEFAULT_SIZE, 80, Short.MAX_VALUE)
                                    .addComponent(forpdGalan, javax.swing.GroupLayout.DEFAULT_SIZE, 80, Short.MAX_VALUE)
                                    .addComponent(forsumGalan, javax.swing.GroupLayout.DEFAULT_SIZE, 80, Short.MAX_VALUE))))
                        .addContainerGap(82, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(pGalan)
                            .addComponent(sGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 45, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(0, 0, Short.MAX_VALUE))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addComponent(lGalan1, javax.swing.GroupLayout.PREFERRED_SIZE, 29, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(galanNum1, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(num1Galan, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(7, 7, 7)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(galanNum2, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(num2Galan, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(9, 9, 9)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(submitGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(clearGalan, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(6, 6, 6)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(sGalan)
                    .addComponent(forsumGalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(dGalan)
                    .addComponent(fordiffGalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(qGalan)
                    .addComponent(forqtGalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(pGalan)
                    .addComponent(forpdGalan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void submitGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_submitGalanActionPerformed
        int n1Galan, n2Galan;
        n1Galan = Integer.parseInt(num1Galan.getText());
        n2Galan = Integer.parseInt(num2Galan.getText());
        int sumGalan, diffGalan, qtGalan, pdGalan;
        sumGalan = n1Galan + n2Galan;
        diffGalan = n1Galan - n2Galan;
        qtGalan = n1Galan / n2Galan;
        pdGalan = n1Galan * n2Galan;
        forsumGalan.setText(Integer.toString(sumGalan));
        fordiffGalan.setText(Integer.toString(diffGalan));
        forqtGalan.setText(Integer.toString(qtGalan));
        forpdGalan.setText(Integer.toString(pdGalan));
    }//GEN-LAST:event_submitGalanActionPerformed

    private void clearGalanActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_clearGalanActionPerformed
        num1Galan.setText("");
        num2Galan.setText("");
        forsumGalan.setText("");
        fordiffGalan.setText("");
        forqtGalan.setText("");
        forpdGalan.setText("");
    }//GEN-LAST:event_clearGalanActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new galan().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton clearGalan;
    private javax.swing.JLabel dGalan;
    private javax.swing.JTextField fordiffGalan;
    private javax.swing.JTextField forpdGalan;
    private javax.swing.JTextField forqtGalan;
    private javax.swing.JTextField forsumGalan;
    private javax.swing.JLabel galanNum1;
    private javax.swing.JLabel galanNum2;
    private javax.swing.JLabel lGalan1;
    private javax.swing.JTextField num1Galan;
    private javax.swing.JTextField num2Galan;
    private javax.swing.JLabel pGalan;
    private javax.swing.JLabel qGalan;
    private javax.swing.JLabel sGalan;
    private javax.swing.JButton submitGalan;
    // End of variables declaration//GEN-END:variables
}
